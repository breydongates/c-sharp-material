<template>
  <div class="well-display">
    <div class="well" v-on:click="setFilter(0)">
      <span class="amount">{{ averageRating }}</span>
      Average Rating
    </div>

    <div class="well" v-on:click="setFilter(1)">
      <span class="amount">{{ numberOfOneStarReviews }}</span>
      1 Star Review{{ numberOfOneStarReviews === 1 ? "" : "s" }}
    </div>

    <div class="well" v-on:click="setFilter(2)">
      <span class="amount">{{ numberOfTwoStarReviews }}</span>
      2 Star Review{{ numberOfTwoStarReviews === 1 ? "" : "s" }}
    </div>

    <div class="well" v-on:click="setFilter(3)">
      <span class="amount">{{ numberOfThreeStarReviews }}</span>
      3 Star Review{{ numberOfThreeStarReviews === 1 ? "" : "s" }}
    </div>

    <div class="well" v-on:click="setFilter(4)">
      <span class="amount">{{ numberOfFourStarReviews }}</span>
      4 Star Review{{ numberOfFourStarReviews === 1 ? "" : "s" }}
    </div>

    <div class="well" v-on:click="setFilter(5)">
      <span class="amount">{{ numberOfFiveStarReviews }}</span>
      5 Star Review{{ numberOfFiveStarReviews === 1 ? "" : "s" }}
    </div>
  </div>
</template>

<script>
export default {
  name: "ReviewStatistics",
  computed: {
    reviews() {
      return this.$store.state.reviews;
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
    },
  },
  methods: {
    setFilter(level) {
      console.debug("Set filter level to " + level);
      this.$store.commit('CHANGE_FILTER_BY_RATING', level);
    },
  },
};
</script>

<style>
</style>