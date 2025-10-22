// const products = [

//     {
//         name: "samsung",
//         price:123.4,
//         stock:300
//     },
//      {
//         name: "toshiba",
//         price:1023.4,
//         stock:100
//     },
//      {
//         name: "iphone",
//         price:2000.4,
//         stock:30
//     },
//      {
//         name: "LG",
//         price:3000,
//         stock:70
//     }
// ]



// const body=document.querySelector("body");


// const table=document.createElement("table")
// const tHead=document.createElement("thead")
// const tRow=document.createElement("tr")

// const tName=document.createElement("th")
// tName.textContent="Name"

// const tPrice=document.createElement("th")
// tPrice.textContent="Price"

// const tStock=document.createElement("th")
// tStock.textContent="Stock"

// tRow.appendChild(tName)
// tRow.appendChild(tPrice)
// tRow.appendChild(tStock)

// tHead.appendChild(tRow)

// table.appendChild(tHead)


// const tBody=document.createElement("tbody")
// table.appendChild(tBody)

// for(let i=0;i<products.length;i++){

//    const row= document.createElement("tr")

//    const tdName=document.createElement("td")
//    tdName.textContent=products[i].name

//    const tdPrice=document.createElement("td")
//    tdPrice.textContent=products[i].price

//    const tdStock=document.createElement("td")
//    tdStock.textContent=products[i].stock

//    row.append(tdName,tdPrice,tdStock)
//    tBody.appendChild(row)

// }

// body.appendChild(table)

// table.setAttribute("border","1")
// table.style.border="1px solid black";

// tRow.append(tName, tPrice, tStock)




// btn.onclick=function(){

//     btn.style.backgroundColor="red";

// }

// btn.onclick=function(){

//     btn.style.color="white";

// }

// var a=5;

// a=7;


// const btns = document.querySelectorAll(".cus-btn")




// for (let i = 0; i < btns.length; i++) {

//     btns[i].addEventListener("click", (e) => {


//            e.target.style.backgroundColor = "red";

//            e.target.remove()

//         console.log(e)
//     })
// }



// btn.addEventListener("click",function(){
//      btn.style.backgroundColor="red";
// })




// btn.addEventListener("click",()=>{
//      btn.style.color="white"
// })




// const div = document.getElementsByClassName("cus-container")[0]
// const miniDiv = document.getElementsByClassName("mini-div")[0]
// const body = document.getElementsByTagName("body")[0]



// var opacity = 1
// body.addEventListener("keyup", (e) => {

//     if (e.key == "ArrowDown") {
//         opacity -= 0.1
        
//     }
//     else if(e.key=="ArrowUp"){
//          opacity += 0.1
//     }

//     body.style.backgroundColor = `rgba(1, 77, 23,${opacity})`
//     console.log(e)
// })


// div.addEventListener("click",(e)=>{

//     e.stopPropagation()
//     div.style.backgroundColor="red"
//     console.log("Parent dive clicklendi")
// })

// miniDiv.addEventListener("click",(e)=>{
//  e.stopPropagation()
//    miniDiv.style.backgroundColor="blue"
//     console.log("Child dive clicklendi")
// })

// div.addEventListener("contextmenu",function(){
//     // this.style.backgroundColor="bisque"
//     console.log("menu achildi")
// })

// div.addEventListener("mouseover",function(){
//     // this.style.backgroundColor="bisque"
//     console.log("over")
// })

// div.addEventListener("mouseenter",function(){
//     // this.style.backgroundColor="bisque"
//     console.log("entered")
// })

// div.addEventListener("mouseout",function(){
//     // this.style.backgroundColor="burlywood"
//     console.log("out")
// })
// div.addEventListener("mousemove",function(){
//     console.log("salam")
// })




// const form=document.getElementsByClassName("form-test")[0]
// const input=document.querySelector("#name")
// const ul=document.querySelector("#list")

// //focus and blur

// form.addEventListener("submit",(e)=>{

//     e.preventDefault()
    
 

//     const li=document.createElement("li")
//     li.textContent=input.value

//     ul.appendChild(li)
//     input.value=""

//     input.focus()
// })



const btns=document.querySelectorAll(".delete")


btns.forEach(btn=>{

    btn.addEventListener("click",(e)=>{
        // e.target.parentElement.parentElement.remove()
        e.target.closest(".col").remove()
    })
})