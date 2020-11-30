<template>
  <div id="app">
    <nav>
      <router-link :to="{name: 'products'}">Products</router-link>
      <router-link :to="{name: 'about'}">About Us</router-link>
    </nav>
    <router-view />
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
