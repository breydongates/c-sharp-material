<template>
  <div id="app">
    <nav>
      <a href="#TODO">Products</a>
      <a href="#TODO">About Us</a>
    </nav>
    <!-- TODO: Show the currently active route's component here -->
  </div>
</template>

<script>
export default {};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  max-width: 800px;
  padding: 1rem;
}
nav {
  margin-bottom: 1rem;
}

nav a {
  margin: 0 0.5rem;
}

nav > a.router-link-exact-active {
  font-weight: bold;
  color: darkblue;
}
</style>
