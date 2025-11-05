
//  const promise=new Promise((rejected,resolve)=>{})

//  console.log(promise)

// import {BASE_URL} from './constants.js'


// const BASE_URL="https://jsonplaceholder.typicode.com"
// const list=document.querySelector("#list")





// function fillHtml(){
//     fetch(`${BASE_URL}/users`)
// .then(response=> response.json())
// .then(users=>{

// users.forEach(user=>{
//     list.innerHTML+=`<li>${user.name}   ${user.address.city}</li>`
// })

// })
// .catch(e=>console.log(e))
// }

// fillHtml()

//GET PUT DELETE POST

// let id=window.prompt("Choose Id:")

// function getUserById(id){
//     fetch(`${BASE_URL}/users/${id}`)
// .then(response=>response.json())
// .then(user=>list.innerHTML=`<li>${user.id+' '+ user.name}</li>`)
// }

// getUserById(1)
// getUserById(2)
// getUserById(id)
// getUserById(id)
// getUserById(id)

// fetch("https://northwind.vercel.app/api/categories/1",{method:"DELETE"})
// .then(response=>console.log(response))
//------------------------------------------------------


const row=document.querySelector("#movies")

fetch("https://api.tvmaze.com/shows")
.then(response=>response.json())
.then(movies=>{

    movies.forEach(movie => {
        row.innerHTML+=`<div class="col-3">
                <div class="card" style="width: 18rem;">
                    <img src="${movie.image.medium}" class="card-img-top" alt="${movie.name}">
                    <div class="card-body">
                        <h5 class="card-title">${movie.name}</h5>
                        <p class="card-text">${movie.rating.average}</p>
                        <a href="details.html?id=${movie.id}" class="btn btn-primary">Go to details</a>
                    </div>
                </div>
            </div>`
    });


})