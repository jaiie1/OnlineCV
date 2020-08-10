// import axios from 'axios'

// const initState = () =>({
//     jobbTitle: [],
//     jobbDescription: [],
// })

// export const state = initState

// export const gettters = {
//     jobbTitleById: state => id => state.jobbTitle.find(x => x.id === id),
//     jobbDescriptionById: state => id => state.jobbDescription.find(x => x.id === id),
//     jobbItems: state => state.jobbTitle.map(x =>({
//         text: x.jobbTitle,
//         value: x.id
//     })),
//     descriptionItem: state => state.jobbDescription.map(x => ({
//         text: x.jobbDescription,
//         value: x.id
//     }))
// }


// export const  mutations = {
//     setJobbs(state, {jobbTitle, jobbDescription}){
//         state.jobbTitle = jobbTitle,
//         state.jobbDescription = jobbDescription
//     },
//     reset(state) {
//         Object.assign(state, initState())
//     }
// }

// export const actions = {
//     async fetchJobbs({commit}){
//         const jobbs = await this.$axios.$get("/api/jobbcontroller");
//         console.log(tricks, difficulties,categories)
//         commit("setJobbs", {jobbTitle, jobbDescription})
//     }
// }