<template>
  <main>
    <!-- Basic Header information. TODO: Introduce a new component for this -->
    <header>
      <h2>Product Reviews for {{productName}}</h2>
      <p class="description">{{productDescription}}</p>
    </header>

    <!-- Display rating statisctics and allow the user to filter down to star ratings -->
    <review-statistics />

    <!-- Allow the user to add new items to the reviews -->
    <add-review-form />

    <!-- List all reviews -->
    <!-- TODO: It'd be nice to have a ReviewCard component -->
    <section
      v-for="review in filteredReviews"
      v-bind:key="review.reviewer"

      class="review"
      v-bind:class="{ favorited: review.favorited }"
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

      <button v-on:click="review.rating = 5" v-if="review.rating < 5">Mark as 5 Star</button>
    </section>
  </main>
</template>

<script>
import AddReviewForm from "./AddReviewForm.vue";
import ReviewStatistics from "./ReviewStatistics.vue";

export default {
  name: "product-review",
  components: {
    ReviewStatistics,
    AddReviewForm,
  },
  data() {
    return {
      productName: "Cigar Parties for Squirrels",
      productDescription: "Because squirrels LOVE their cigars",
      // TODO: Move this data up to a centralized data store
      filterByRating: 0,
      reviews: [
        {
          reviewer: "Malcolm Gladwell",
          title: "What a book!",
          review:
            "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language.",
          rating: 3,
          favorited: false,
        },
        {
          reviewer: "Tim Ferriss",
          title: "Had a cigar party started in less than 4 hours.",
          review:
            "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
          rating: 4,
          favorited: false,
        },
        {
          reviewer: "Ramit Sethi",
          title: "What every new entrepreneurs needs. A door stop.",
          review:
            "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
          rating: 1,
          favorited: false,
        },
        {
          reviewer: "Gary Vaynerchuk",
          title: "And I thought I could write",
          review:
            "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
          rating: 3,
          favorited: false,
        },
      ],
    };
  },
  methods: {},
  computed: {
    filteredReviews() {
      let reviews = this.reviews;

      if (this.filterByRating) {
        reviews = reviews.filter((r) => r.rating === this.filterByRating);
      }

      return reviews;
    },
  },
};
</script>