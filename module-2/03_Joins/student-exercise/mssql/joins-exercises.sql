-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT *
FROM actor
WHERE first_name = 'Nick' AND last_name = 'Stallone'

SELECT *
FROM film_actor
WHERE actor_id = 44

--this one works
SELECT title, actor_id
FROM film_actor
JOIN film ON film.film_id = film_actor.film_id
WHERE actor_id = 44


-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT * 
FROM actor
WHERE first_name = 'Rita' AND last_name = 'Reynolds'

SELECT title, actor_id
FROM film_actor
JOIN film ON film.film_id = film_actor.film_id
WHERE actor_id = 135
-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT * 
FROM actor
WHERE first_name = 'Judy' AND last_name = 'Dean'
OR first_name = 'River' AND last_name = 'Dean'

SELECT title
FROM film_actor
JOIN film ON film.film_id = film_actor.film_id
WHERE actor_id = 35 OR actor_id = 143
-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT *
FROM category
WHERE name = 'Documentary'

SELECT title AS Documentaries
FROM film_category
JOIN film ON film.film_id = film_category.film_id
WHERE category_id = 6
-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT * 
FROM category
WHERE name = 'Comedy'

SELECT title AS Comedies
FROM film_category
JOIN film ON film.film_id = film_category.film_id
WHERE category_id = 5
-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT * 
FROM category
WHERE name = 'Children'

SELECT title AS 'G rated children films'
FROM film_category
JOIN film ON film.film_id = film_category.film_id
WHERE category_id = 3
AND film.rating = 'G'
-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT * 
FROM category
WHERE name = 'Family'

SELECT * 
FROM film
WHERE length < 120

SELECT title, film.rating, film.length
FROM film_category
JOIN film ON film.film_id = film_category.film_id
WHERE category_id = 8
AND film.rating = 'G'
AND film.length < 120

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT * 
FROM actor
WHERE first_name = 'Matthew' AND last_name = 'Leigh'
-- actor id 103

SELECT title, film.rating
FROM film_actor
JOIN film ON film_actor.film_id = film.film_id
WHERE actor_id = 103 AND film.rating = 'G'


-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT *
FROM category
WHERE name = 'Sci-Fi' -- category id is 14

SELECT title AS 'Sci-Fi films', film.release_year AS 'Released in 2006'
FROM film_category
JOIN film ON film_category.film_id = film.film_id
WHERE category_id = 14
AND film.release_year = 2006

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT * 
FROM actor
WHERE first_name = 'Nick'
AND last_name = 'Stallone' --id is 44

SELECT * 
FROM category
WHERE name = 'Action' -- id is 1

SELECT title AS 'Action Films Starring Nick Stallone'
FROM film_category
JOIN film ON film_category.film_id = film.film_id
JOIN film_actor ON film.film_id = film_actor.film_id
WHERE actor_id = 44
AND category_id = 1


-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT address.address, city, district, country
FROM store
JOIN address ON address.address_id = store.address_id
JOIN city ON city.city_id = address.city_id
JOIN country ON city.country_id = country.country_id



-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT *
FROM store

SELECT store.store_id, address, staff.first_name + ' ' + staff.last_name AS 'Manager Name'
FROM store
JOIN address ON address.address_id = store.address_id
JOIN staff ON staff.store_id = store.store_id

-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT TOP (10) customer.first_name + ' ' + customer.last_name AS 'Customer Name', COUNT(rental.customer_id) AS 'Amount of Rentals'
FROM customer
JOIN rental ON customer.customer_id = rental.customer_id
JOIN store ON customer.store_id = store.store_id
GROUP BY customer.customer_id, customer.first_name, customer.last_name
ORDER BY [Amount of Rentals] DESC




-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT TOP (10) customer.first_name + ' ' + customer.last_name AS 'Customer Name', SUM(payment.amount) AS 'Money Spent'
FROM customer
JOIN payment ON customer.customer_id = payment.customer_id
GROUP BY customer.customer_id, customer.first_name, customer.last_name
ORDER BY [Money Spent] DESC

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)
SELECT  store.store_id, address.address AS 'Address', COUNT(inventory.inventory_id) AS 'Total Rentals', SUM(payment.amount) AS 'Total Amount of Sales', AVG(payment.amount) AS 'Average Sale'
FROM store
JOIN address ON store.address_id = address.address_id
JOIN inventory ON store.store_id = inventory.store_id
JOIN rental ON inventory.inventory_id = rental.inventory_id
JOIN payment ON rental.rental_id = payment.rental_id
GROUP BY address.address, store.store_id
-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT TOP(10) film.title, COUNT(rental.rental_id) AS 'Times Rented'
FROM inventory
JOIN rental ON inventory.inventory_id = rental.inventory_id
JOIN film ON inventory.film_id = film.film_id
GROUP BY inventory.film_id, film.title
ORDER BY [Times Rented] DESC

-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT TOP(5) category.name, COUNT(rental.inventory_id) AS 'Total Rentals'
FROM inventory
JOIN rental ON inventory.inventory_id = rental.inventory_id
JOIN film ON inventory.film_id = film.film_id
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON category.category_id = film_category.category_id
GROUP BY category.name
ORDER BY [Total Rentals] DESC

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT * 
FROM category -- id is 1

SELECT TOP (5) film.title AS 'Action Film Titles', COUNT(rental.inventory_id) AS 'Total Rentals'
FROM inventory
JOIN rental ON inventory.inventory_id = rental.inventory_id
JOIN film ON inventory.film_id = film.film_id
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE category.category_id = 1
GROUP BY category.name, film.title
ORDER BY [Total Rentals] DESC
-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)

SELECT TOP (10) actor.first_name + ' ' + actor.last_name AS 'Actor Name', COUNT(rental.inventory_id) AS 'Total Rentals'
FROM inventory
JOIN rental ON inventory.inventory_id = rental.inventory_id
JOIN film ON inventory.film_id = film.film_id
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
GROUP BY actor.actor_id, actor.first_name, actor.last_name
ORDER BY [Total Rentals] DESC

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT*
FROM category
WHERE name = 'Comedy' -- id is 5

SELECT TOP (5) actor.first_name + ' ' + actor.last_name AS 'Actor Name', COUNT(rental.inventory_id) AS 'Total Rentals'
FROM inventory
JOIN rental ON inventory.inventory_id = rental.inventory_id
JOIN film ON inventory.film_id = film.film_id
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON film_category.category_id = category.category_id
WHERE category.name = 'Comedy'
GROUP BY actor.actor_id, actor.first_name, actor.last_name
ORDER BY [Total Rentals] DESC