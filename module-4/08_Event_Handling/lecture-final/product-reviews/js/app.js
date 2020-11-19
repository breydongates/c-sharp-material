const name = 'Cigar Parties for Dummies';
let description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
let reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue (I hope that's glue) and there's writing on it, in some language.",
    rating: 3
  }
];

/**
 * Add our product name to the page title
 * Get our page page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  const pageTitle = document.getElementById('page-title');
  pageTitle.querySelector('.name').innerHTML = name;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  document.querySelector('.description').innerHTML = description;
}

/**
 * I will display all of the reviews in the reviews array
 */
function displayReviews() {
  if ('content' in document.createElement('template')) {
    reviews.forEach((review) => {
      displayReview(review);
    });
  } else {
    console.error('Your browser does not support templates');
  }
}

/**
 * Displays all reviews on the page
 * @param {Object} review The review to display
 */
function displayReview(review) {
  const main = document.getElementById('main');

  // This grabs a template out of the HTML and clones it, then selects the template to customize it
  const clonedNode = document.getElementById('review-template').content.cloneNode(true);
  clonedNode.querySelector('h4').innerHTML = review.reviewer;
  clonedNode.querySelector('h3').innerHTML = review.title;
  clonedNode.querySelector('p').innerHTML = review.review;

  // there will always be 1 star because it is a part of the template
  for (let i = 1; i < review.rating; ++i) {
    const img = clonedNode.querySelector('img').cloneNode();
    clonedNode.querySelector('.rating').appendChild(img);
  }
  
  main.appendChild(clonedNode);
}

/**
 * I will show / hide the add review form
 */
function showHideForm() {
  const form = document.querySelector('form');
  const btn = document.getElementById('btnToggleForm');

  if (form.classList.contains('d-none')) {
    form.classList.remove('d-none');
    btn.innerText = 'Hide Form';
    document.getElementById('name').focus();
  } else {
    resetFormValues();
    form.classList.add('d-none');
    btn.innerText = 'Add Review';
  }
}

/**
 * I will reset all of the values in the form.
 */
function resetFormValues() {
  const form = document.querySelector('form');
  const inputs = form.querySelectorAll('input');
  inputs.forEach((input) => {
    input.value = '';
  });
  document.getElementById('rating').value = 1;
  document.getElementById('review').value = '';
}

// LECTURE STARTS HERE ---------------------------------------------------------------

// Only call initialize when the DOM is ready
document.addEventListener('DOMContentLoaded', e => {
  console.log('DOM Ready', e);
  initialize();
});

function initialize() {
  // set the product reviews page title
  setPageTitle();

  // set the product reviews page description
  setPageDescription();

  // display all of the product reviews on our page
  displayReviews();

  // -----------------------------------------------

  // When the user clicks on btnToggleForm, call showHideForm
  const btnToggleForm = document.querySelector('#btnToggleForm');
  btnToggleForm.addEventListener('click', e => {
    console.log('Button clicked', e.target);
    showHideForm();
    e.stopPropagation();
  });

  // When the user clicks btnSaveReview, call saveReview
  const btnSaveReview = document.querySelector('#btnSaveReview');
  btnSaveReview.addEventListener('click', e => {
    saveReview();
    e.preventDefault();
  });

  // -----------------------------------------------

  // When the user double clicks the description paragraph, call showDescriptionEdit and pass it the event
  const descParagraph = document.querySelector('p.description');
  descParagraph.addEventListener('dblclick', e => {
    showDescriptionEdit(e);
  });

  // When the user's mouse leaves the input with an ID of inputDesc, call exitDescriptionEdit without saving
  const descInput = document.querySelector('#inputDesc');
  descInput.addEventListener('mouseleave', e => {
    console.debug('Mouse left input', e);
    exitDescriptionEdit(e, false);
  });

  // When the user presses a key on the input with an ID of inputDesc, 
  // check for enter and escape and call exitDescriptionEdit
  descInput.addEventListener('keyup', e => {
    console.debug('Key Up', e);
    switch (e.key) {
      case "Enter":
        exitDescriptionEdit(e, true);
        break;

      case "Escape":
        exitDescriptionEdit(e, false);
        break;
    }
  });

  // ------------------------------------------------

  // Add a click listener for when the user clicks the body element
  document.querySelector('body').addEventListener('click', e => {
    console.log('Recorded a click on body', e.target);
  });
  
}

/**
 * I will save the review that was added using the add review from
 */
function saveReview() {
  // Get the value of the name, title, review, and rating
  const nameInput = document.querySelector('#name');
  const name = nameInput.value;

  console.log('The name is ' + name);

  const title = document.querySelector('#title').value;
  const review = document.querySelector('#review').value;
  const rating = document.querySelector('#rating').value;

  // Create a new review object with these values for reviewer, title, review, and rating
  const newReview = {
    reviewer: name,
    title: title,
    review: review,
    rating: rating,
  };

  console.debug('Adding review ', newReview);

  // Add the new object to reviews
  reviews.push(newReview);

  // Call displayReview with the new review as a parameter
  displayReview(newReview);

  // Call showHideForm to toggle the form visibility
  showHideForm();
}

/**
 * Take an event on the description and swap out the description for a text box.
 *
 * @param {Event} event the event object
 */
function showDescriptionEdit(event) {
  const target = event.target;

  const textBox = target.nextElementSibling;
  textBox.value = description;
  textBox.classList.remove('d-none');

  target.classList.add('d-none');

  textBox.focus();
}

/**
 * Take an event on the text box and set the description to the contents
 * of the text box and then hide the text box and show the description.
 *
 * @param {Event} event the event object representing the description we're editing
 * @param {Boolean} shouldSave should we save the description text
 */
function exitDescriptionEdit(event, shouldSave) {
  const input = event.target;

  const desc = input.previousElementSibling;

  // If we're saving, get the new value and set that into description and desc
  if (shouldSave) {
    description = input.value;
    desc.innerText = description;
  }

  input.classList.add('d-none');
  desc.classList.remove('d-none');
}