<template>
  <header>
    <h2>Product Reviews for {{ productName }}</h2>
    <p class="description">{{ productDescription }}</p>
  </header>
</template>

<script>
export default {
    props: {
        productName: String,
        productDescription: String,
    }
};
</script>

<style>
</style>