-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
SELECT *
FROM actor

INSERT INTO actor
(first_name, last_name)
VALUES ('Hampton', 'Avenue')

INSERT INTO actor
(first_name, last_name)
VALUES ('Lisa', 'Byway')

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
SELECT *
FROM film

INSERT INTO film
(title, description, release_year, language_id, length)
VALUES('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece',
2008, 1, 198)

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
-- film id 1001
SELECT *
FROM film_actor

SELECT * 
FROM actor

INSERT INTO film_actor(actor_id,film_id)
VALUES(201, 1001)

INSERT INTO film_actor(actor_id,film_id)
VALUES(202, 1001)
-- 4. Add Mathmagical to the category table.
SELECT *
FROM category

INSERT INTO category(name)
VALUES('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY" --274, "KARATE MOON", "RANDOM GO" 714, and "YOUNG LANGUAGE"

SELECT *
FROM film_category
WHERE category_id = 17


INSERT INTO film_category(film_id, category_id)
VALUES(1001, 17)

UPDATE film_category
SET category_id = 17
WHERE film_id IN
(SELECT film_id
FROM film
WHERE title = 'EGG IGBY')

UPDATE film_category
SET category_id = 17
WHERE film_id IN
(SELECT film_id
FROM film
WHERE title = 'KARATE MOON')

UPDATE film_category
SET category_id = 17
WHERE film_id IN
(SELECT film_id
FROM film
WHERE title = 'RANDOM GO')

UPDATE film_category
SET category_id = 17
WHERE film_id IN
(SELECT film_id
FROM film
WHERE title = 'YOUNG LANGUAGE')


-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
SELECT *
FROM film

SELECT *
FROM film_category
WHERE category_id = 17

UPDATE film
SET rating = 'G'
WHERE film_id IN
(SELECT film_id
FROM film_category
WHERE category_id = 17)


-- 7. Add a copy of "Euclidean PI" to all the stores.
SELECT * 
FROM inventory
WHERE film_id = 1001

INSERT INTO inventory(film_id, store_id)
VALUES (1001, 1)

INSERT INTO inventory(film_id, store_id)
VALUES (1001, 2)

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- No, because the film table is connected with the stores, so the films would need to be deleted from 
-- the stores before being deleted 
SELECT *
FROM film
WHERE title = 'Euclidean PI'

DELETE
FROM film
WHERE title = 'Euclidean PI'


-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- No, mathmagical is located in multiple locations as a private key, would need to delete from multiple locations first
SELECT *
FROM category
WHere name = 'Mathmagical'

DELETE
FROM category
WHere name = 'Mathmagical'

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- Yes, because it removed all instances of where mathmagical was used. 
DELETE
FROM film_category
WHERE category_id = 17


-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- Mathmagical deleted, because all instances where the category id of mathmagical were deleted,
-- so since mathmagical was not used by anything, you can delete the name.
-- Euclidean PI was still not deleted, because it is still located in the store inventory.
DELETE
FROM category
WHERE name = 'Mathmagical'

DELETE
FROM film
WHERE title = 'Euclidean PI'

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
-- You need to delete every instance where the film is located. 
--Since it's in film_actor, you need to remove anything associated with the film.
SELECT *
FROM film
WHERE title = 'Euclidean PI'

DELETE
FROM film
WHERE title = 'Euclidean PI'

DELETE
FROM inventory
WHERE film_id = 1001

DELETE
FROM film_actor
WHERE film_id = 1001