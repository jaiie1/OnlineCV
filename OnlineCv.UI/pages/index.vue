<template>
 <div class="Exampel">

   <div>
    <h1>Jobbs</h1>    
   
    <ul>
      <li v-for="post of posts" :key="post.id">
        {{ post.jobbTitel }}
        {{ post.jobbDescription }}
      </li>
    </ul>
  </div>
   
 </div>
 
         
  
</template>

<script>
import Axios from 'axios'
process.env['NODE_TLS_REJECT_UNAUTHORIZED'] = 0
export default {

  name: "Exampel",
  data: () => ({
    posts: []     
  }),
   asyncData (context) {
      console.log("working");
      return Axios.get("https://localhost:44357/api/jobbcontroller")
       .then(({data}) => {
      return {posts: data}
    })    
    },
    fetchOnServer: false     
}
</script>