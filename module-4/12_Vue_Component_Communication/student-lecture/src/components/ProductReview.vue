<template>
  <main>
    <!-- Basic info -->
    <h2>Product Reviews for {{ name }}</h2>
    <p class="description">{{ description }}</p>

    <!-- Display information about our individual reviews -->
    <div class="well-display">
      <div class="well" v-on:click="setFilter(0)">
        <span class="amount">{{ averageRating }}</span>
        Average Rating
      </div>

      <div class="well" v-on:click="setFilter(1)">
        <span class="amount">{{ numberOfOneStarReviews }}</span>
        1 Star Review{{ numberOfOneStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" v-on:click="setFilter(2)">
        <span class="amount">{{ numberOfTwoStarReviews }}</span>
        2 Star Review{{ numberOfTwoStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" v-on:click="setFilter(3)">
        <span class="amount">{{ numberOfThreeStarReviews }}</span>
        3 Star Review{{ numberOfThreeStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" v-on:click="setFilter(4)">
        <span class="amount">{{ numberOfFourStarReviews }}</span>
        4 Star Review{{ numberOfFourStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" v-on:click="setFilter(5)">
        <span class="amount">{{ numberOfFiveStarReviews }}</span>
        5 Star Review{{ numberOfFiveStarReviews === 1 ? '' : 's' }}
      </div>
    </div>

    <!-- Show the addReviewSection when clicked and hide this button -->
    <input type="button" value="Add Review" v-on:click="showAddReview = !showAddReview" v-if="!showAddReview"> 
    
    <!-- Allow the user to add a review -->
    <section id="addReviewSection" v-if="showAddReview"> <!-- could also v-show to include it in the DOM with display: none if false -->
      <form>
        <div class="form-element">
            <label for="reviewer">Name:</label>
            <input id="reviewer" type="text" v-model.trim="newReview.reviewer" />
        </div>
        <div class="form-element">
            <label for="title">Title:</label>
            <input id="title" type="text" v-model.trim.lazy="newReview.title" />
        </div>
        <div class="form-element">
            <label for="rating">Rating:</label>
            <select id="rating" v-model.number="newReview.rating" >
                <option value="1">1 Star</option>
                <option value="2">2 Stars</option>
                <option value="3">3 Stars</option>
                <option value="4">4 Stars</option>
                <option value="5">5 Stars</option>
            </select>
        </div>
        <div class="form-element">
            <label for="review">Review:</label>
            <textarea id="review" v-model.trim="newReview.review"></textarea>
        </div>
        <!--<input type="submit" value="Save" v-on:click="addNewReview($event)">-->
        <input type="submit" value="Save" v-on:click.prevent="addNewReviewRevised()">
        <input type="button" value="Cancel" @click="showAddReview = false"> <!-- @ == v-on: -->
      </form>
    </section>

    <!-- List all reviews -->
    <section
      class="review"
      v-bind:class="{ favorited: review.favorited }"
      v-for="review in filteredReviews"
      v-bind:key="review.id"
    >
      <h4>{{ review.reviewer }}</h4>
      <div class="rating">
        <img
          src="../assets/star.png"
          v-bind:title="review.rating + ' Star Review'"
          class="ratingStar"
          v-for="n in review.rating"
          v-bind:key="n"
        />
      </div>
      <h3>{{ review.title }}</h3>

      <p>{{ review.review }}</p>

      <p>
        Favorite?
        <input type="checkbox" v-model="review.favorited" />
      </p>
    </section>
  </main>
</template>

<script>
export default {
  name: "product-review",
  data() {
    return {
      name: "Cigar Parties for Dummies",
      description:
        "Host and plan the perfect cigar party for all of your squirrelly friends.",
      showAddReview: false,
      newReview: {
        id: null,
        reviewer: '',
        title: '',
        review: '',
        rating: 0,
        favorited: false,
      },
      filterByRating: 0,
      nextId: 5,
      reviews: [
        {
          id: 1,
          reviewer: "Malcolm Gladwell",
          title: "What a book!",
          review:
            "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language.",
          rating: 3,
          favorited: false
        },
        {
          id: 2,
          reviewer: "Tim Ferriss",
          title: "Had a cigar party started in less than 4 hours.",
          review:
            "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
          rating: 4,
          favorited: false
        },
        {
          id: 3,
          reviewer: "Ramit Sethi",
          title: "What every new entrepreneurs needs. A door stop.",
          review:
            "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
          rating: 1,
          favorited: false
        },
        {
          id: 4,
          reviewer: "Gary Vaynerchuk",
          title: "And I thought I could write",
          review:
            "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
          rating: 3,
          favorited: false
        }
      ]
    };
  },
  methods: {
    setFilter(level) {
      this.filterByRating = level;
    },
    addNewReview(e) {
      console.log('Adding a new review!');
      e.preventDefault();
    },
    addNewReviewRevised() {
      console.log('Revised add new review');

      this.newReview.id = this.nextid;
      this.nextId += 1;

      this.reviews.unshift(this.newReview);

      // Reset the new review so it's a new object with blank values
      // this.newReview = {...defaultReview};
      this.newReview = {
        id: null,
        reviewer: '',
        title: '',
        rating: 0,
        favorited: false,
        review: '',
      }

      this.showAddReview = false;
    }
  },
  computed: {
    filteredReviews() {
      let reviews = this.reviews;

      // Filtering goes here...
      if (this.filterByRating) {
        reviews = reviews.filter(r => r.rating === this.filterByRating);
      }

      return reviews;
    },
    averageRating() {
      let sum = this.reviews.reduce((currentSum, review) => {
        return currentSum + review.rating;
      }, 0);
      return (sum / this.reviews.length).toFixed(2);
    },
    numberOfOneStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 1);
      }, 0);
    },
    numberOfTwoStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 2);
      }, 0);
    },
    numberOfThreeStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 3);
      }, 0);
    },
    numberOfFourStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 4);
      }, 0);
    },
    numberOfFiveStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 5);
      }, 0);
    }
  }
};
</script>

<style scoped>
main {
  margin: 1rem 0;
}

main div.well-display {
  display: flex;
  justify-content: space-around;
  margin-bottom: 1rem;
}

main div.well-display div.well {
  display: inline-block;
  width: 15%;
  border: 1px black solid;
  border-radius: 6px;
  text-align: center;
  margin: 0.25rem;
}

main div.well-display div.well span.amount {
  color: darkslategray;
  display: block;
  font-size: 2.5rem;
}

main section.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

main section.review.favorited {
  background-color: lightyellow;
}

main section.review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

main section.review div.rating img {
  height: 100%;
}

main section.review p {
  margin: 20px;
}

main section.review h3 {
  display: inline-block;
}

main section.review h4 {
  font-size: 1rem;
}

div.form-element {
  margin-top: 10px;
}
div.form-element > label {
  display: block;
}
div.form-element > input, div.form-element > select {
  height: 30px;
  width: 300px;
}
div.form-element > textarea {
  height: 60px;
  width: 300px;
}
form > input[type=button] {
  width: 100px;
}
form > input[type=submit] {
  width: 100px;
  margin-right: 10px;
}
</style>

