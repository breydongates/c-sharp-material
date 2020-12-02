<template>
  <div>
      <h1><best-seller-list /></h1>
      
      <h1> <new-releases-list /> </h1>
      
  </div>
</template>

<script>
import BestSellerList from '../components/BestSellerList.vue'
import NewReleasesList from '../components/NewReleasesList.vue'
export default {
    components: { 
        BestSellerList,
         NewReleasesList, } 
}
</script>

<style>

</style>