<template>
  <div id="exampel">
    <ul id="example-1">
  <li v-for="item in items" :key="item.Jobbtitle">
    {{ item.Jobbtitle }}
  </li>
    </ul>

  </div>
 
         
  
</template>

<script>
import Logo from '~/components/Logo.vue'
import VuetifyLogo from '~/components/VuetifyLogo.vue'
import Axios from 'axios'
process.env['NODE_TLS_REJECT_UNAUTHORIZED'] = 0
export default {

  name: "Exampel",

  data: () => ({
    items:[
      {Jobbtitle: "asd"}      
    ]
  }),

  asyncData(payload){
    console.log("working");
    return Axios.get("https://localhost:44357/api/jobbcontroller")
    .then(({items}) => {
      return {Jobbtitle: items}
    })
  }   
  
}
</script>