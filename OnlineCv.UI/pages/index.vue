<template>
  
      
        <v-card
    class="mx-auto"
    max-width="344"
  >
    <v-card-text>
      
      <p class="display-1 text--primary">
        {{message}}
      </p>      
    </v-card-text>
    <v-card-actions>
      <v-btn
        text
        color="deep-purple accent-4"
      >
        Reboot
      </v-btn>
    </v-card-actions>
  </v-card>
         
  
</template>

<script>
import Logo from '~/components/Logo.vue'
import VuetifyLogo from '~/components/VuetifyLogo.vue'
import Axios from 'axios'
// process.env['NODE_TLS_REJECT_UNAUTHORIZED'] = 0

export default {
  components: {
    Logo,
    VuetifyLogo
  },

  data: () => ({
    message : ""
  }),

  asyncData(payload){
    console.log("working");
    return Axios.get("https://localhost:44357/api/home")
    .then(({data}) => {
      return {message: data}
    })
  }   

  
}
</script>
