import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  // TODO: Add a base route listing all products
  // TODO: Add an about route

  // TODO: Add a product details route
  // TODO: Add an add review route

  // TODO: Add a not found route
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
