<template>
  <div class="book-container">
    <book-card v-bind:book="book" v-for="book in $store.state.books" v-bind:key="book.isbn" />
 
  </div>
</template>

<script>
import BookCard from '@/components/BookCard.vue';


export default {
    name: 'reading-list',
    components: {
        BookCard,
    },
    props: {
      isbn: Number,
    },
    computed: {
      book() {
        return this.$store.state.books.find(b => b.isbn == this.isbn)
      }
    },
}
</script>

<style>
.book-container {
    display:flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}
</style>