const name = 'Cigar Parties for Dummies';

/**
 * Add our product name to the page title
 * Get our page page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  const span = document.querySelector('.name');

  span.innerText = name;
}

const description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  const para = document.querySelector('div#main > .description');

  para.innerText = description;
}

const reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue <em>(I hope that's glue)</em> and there's writing on it, in some language.",
    rating: 3
  },
  {
    reviewer: 'Tim Ferriss',
    title: 'Had a cigar party started in less than 4 hours.',
    review:
      "It should have been called <q>the four hour cigar party</q>. That's amazing. I have a new idea for muse because of this.",
    rating: 4
  },
  {
    reviewer: 'Ramit Sethi',
    title: 'What every new entrepreneurs needs. A door stop.',
    review:
      "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. I just wish that I learned something from this book.",
    rating: 1
  },
  {
    reviewer: 'Gary Vaynerchuk',
    title: 'And I thought I could write',
    review:
      "There are a lot of good, solid tips in this book. I don't want to ruin it, but <strong>prelighting all the cigars</strong> is worth the price of admission alone.",
    rating: 3
  }
];

/**
 * I will display all of the reviews on the page.
 * I will loop over the array of reviews and use some helper functions
 * to create the elements needed for our markup and add them to the DOM
 */
function displayReviews() {
  const main = document.querySelector('#main');

  // For Each Review:
  reviews.forEach(review => {
    // Create a new div and store it in a variable named container
    let container = document.createElement('div');

    // Add the 'review' class to the element we just created
    container.classList.add('review');

    // Call the following helper methods to add little pieces of the user interface
    addReviewer(container, review.reviewer);
    addRating(container, review.rating);
    addTitle(container, review.title);
    addReview(container, review.review);

    // Add the new div to the main application area
    main.appendChild(container);
  });

  const ratingDivs = document.querySelectorAll('div.review > div');
  ratingDivs.forEach(div => div.classList.add('rating'));
}

/**
 * I will create a new h4 element with the name of the reviewer and append it to
 * the parent element that is passed to me.
 *
 * @param {HTMLElement} parent: The element to append the reviewer to
 * @param {string} name The name of the reviewer
 */
function addReviewer(parent, name) {
  const header = document.createElement('h4');

  header.innerText = name;

  parent.appendChild(header);
}

/**
 * I will add an h3 element along with the review title
 * @param {HTMLElement} parent the element that the title header should be added to
 * @param {string} title a string representing the title of the review
 */
function addTitle(parent, title) {
  const header = document.createElement('h3');

  header.innerText = title;

  parent.appendChild(header);
}

/**
 * I will add the product review as a paragraph. Review may contain HTML content
 * @param {HTMLElement} parent the element that the paragraph should be added to
 * @param {string} review a string representing the body of the review. May contain HTML.
 */
function addReview(parent, review) {
  const para = document.createElement('p');

  para.innerHTML = review;

  parent.appendChild(para);
}

/**
 * I will add the rating div with a class of rating.
 * Inside of this div, add a star image (img/star.png) for the number of ratings 1-5
 * @param {HTMLElement} parent the element that the div should be added to
 * @param {Number} numberOfStars a Number indicating the number of stars for the review from 1-5
 */
function addRating(parent, numberOfStars) {
  const ratingDiv = document.createElement('div');
  // ratingDiv.classList.add('rating');

  for (let i = 0; i < numberOfStars; i++) {
    const star = document.createElement('img');

    star.setAttribute('src', 'img/star.png');
    // star.src = 'img/star.png';

    ratingDiv.appendChild(star);
  }

  parent.insertAdjacentElement('beforeend', ratingDiv);
}

// set the product reviews page title
setPageTitle();
// set the product reviews page description
setPageDescription();
// display all of the product reviews on our page
displayReviews();
