import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex);

export default new Vuex.Store({
    // State contains application-wide data that can be referenced between components
    state: {
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
  
    },
    // Mutations are what are allowed to actually change application state
    mutations: {
        CHANGE_FILTER_BY_RATING(state, numberOfStars) {
            state.filterByRating = numberOfStars;
        },
        ADD_REVIEW(state, review) {
            state.reviews.unshift(review);
        },
        SET_AS_FIVE_STAR(state, review) {
            const r = state.reviews.find(x => x.reviewer === review.reviewer);
            r.rating = 5;
        },
    },
    strict: true
});
