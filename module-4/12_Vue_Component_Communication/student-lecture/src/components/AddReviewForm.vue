<template>
  <section>
    <!-- Show the addReviewSection when clicked and hide this button -->
    <input
      type="button"
      value="Add Review"
      v-on:click="showAddReview = true"
      v-if="!showAddReview"
    />

    <!-- Allow the user to add a review -->
    <form v-if="showAddReview">
      <div class="form-element">
        <label for="reviewer">Name:</label>
        <input id="reviewer" type="text" v-model.trim="newReview.reviewer" />
      </div>
      <div class="form-element">
        <label for="title">Title:</label>
        <input id="title" type="text" v-model.trim="newReview.title" />
      </div>
      <div class="form-element">
        <label for="rating">Rating:</label>
        <select id="rating" v-model.number="newReview.rating">
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
      <input
        type="submit"
        value="Save"
        v-on:click.prevent="addNewReviewRevised()"
      />
      <input type="button" value="Cancel" v-on:click="showAddReview = false" />
    </form>
  </section>
</template>

<script>
export default {
  name: "AddReviewForm",
  data() {
    return {
      newReview: {
        reviewer: "",
        title: "",
        review: "",
        rating: 0,
        favorited: false,
      },
      showAddReview: false,
    };
  },
  methods: {
    addNewReviewRevised() {
      // TODO: Add this.newReview to a centralized object store

      // Reset the new review so it's a new object with blank values
      this.newReview = {
        reviewer: "",
        title: "",
        rating: 0,
        favorited: false,
        review: "",
      };

      this.showAddReview = false;
    },
  },
};
</script>

<style>
</style>