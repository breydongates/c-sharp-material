<template>
  <div id="app">
    <h1>Hello Vue.js </h1>
    <p>Welcome to my nightmare</p>
    <ProductReview />
  </div>
</template>

<script>
import ProductReview from './components/ProductReview.vue'

export default {
  name: 'App',
  components: {
    ProductReview
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
