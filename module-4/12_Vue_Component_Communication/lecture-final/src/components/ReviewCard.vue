<template>
  <section class="review" v-bind:class="{ favorited: review.favorited }">
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

    <button v-on:click="setToFiveStars()" 
            v-if="review.rating < 5">
      Mark as 5 Star
    </button>
  </section>
</template>

<script>
export default {
    props: {
        review: Object,
    },
    methods: {
        setToFiveStars() {
            this.$store.commit('SET_AS_FIVE_STAR', this.review);
        }
    }
};
</script>

<style>
</style>