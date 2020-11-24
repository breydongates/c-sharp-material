<template>
  <main>
    <!-- Basic Header information. -->
    <product-info v-bind:productName="prodName" 
                  v-bind:productDescription="prodDescription" >
    </product-info>

    <!-- Display rating statisctics and allow the user to filter down to star ratings -->
    <review-statistics />

    <!-- Allow the user to add new items to the reviews -->
    <add-review-form />

    <!-- List all reviews -->
    <review-card
      v-for="r in filteredReviews"
      v-bind:key="r.reviewer"
      v-bind:review="r">
    </review-card>
  </main>
</template>

<script>
import AddReviewForm from "./AddReviewForm.vue";
import ReviewStatistics from "./ReviewStatistics.vue";
import ProductInfo from "./ProductInfo.vue";
import ReviewCard from "./ReviewCard.vue";

export default {
  name: "product-review",
  components: {
    ReviewStatistics,
    AddReviewForm,
    ProductInfo,
    ReviewCard,
  },
  data() {
    return {
      prodName: "Cigar Parties for Squirrels",
      prodDescription: "Because squirrels LOVE their cigars",
    };
  },
  methods: {},
  computed: {
    filteredReviews() {
      let reviews = this.$store.state.reviews;

      if (this.$store.state.filterByRating) {
        reviews = reviews.filter((r) => r.rating === this.$store.state.filterByRating);
      }

      return reviews;
    },
  },
};
</script>