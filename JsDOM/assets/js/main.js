



//Task



// function Sumtotal(num,sum){
//     if(sum==undefined){
//         sum=0;
//     }
//     if(num<0){
//         num*=(-1);
//     }


//    //0   12
//     if(num>0){
//         sum+=num%10;
//         num-=(num%10);
//         num/=10;
//         return Sumtotal(num,sum)
//     }
//     else{
//          return sum;
//     }
// }

// console.log(Sumtotal(1902))

// class Person{

//     constructor(name, surname){
//         this.name=name
//         this.surname=surname
//     }
// }



// const person=new Person("subhan","testov")



// const div=document.getElementById("div1")

// div.style.color="red"
// div.style.width="200px"
// div.style.height="70px"
// div.style.backgroundColor="bisque"

// div.innerText="salam"







// js DOM Document Object Model
// js BOM browser Object Model




// const divs=document.getElementsByClassName("test")




// for(let i=0;i<divs.length;i++){

//     const parag=document.createElement("p")

//     divs[i].appendChild(parag)
//     parag.textContent="salam"

//     parag.classList.add("text-red")

//     // divs[i].innerText="Salam"
// }




// const nameInput=document.querySelector("#name")

// nameInput.setAttribute("placeholder","Name here....")
// nameInput.setAttribute("value","Sabir")
// nameInput.setAttribute("disabled","true")
// nameInput.removeAttribute("disabled")



















// const divisions=document.querySelectorAll(".test")


// console.log(divs)
// console.log(divisions)


// console.log(document)

















const div=document.querySelector("#student")


const list=document.createElement("ul")

div.appendChild(list)






const arr=[

     {
        name:"Eynulla",
        group:"PB306",
        age:18,
        img:"https://cdn-icons-png.flaticon.com/512/4042/4042171.png"
    },
     {
        name:"Aytac",
        group:"PB306",
        age:19,
        img:"https://cdn-icons-png.flaticon.com/512/3231/3231671.png"
    },
     {
        name:"Elchin",
        group:"PB306",
        age:19,
        img:"https://cdn-icons-png.flaticon.com/512/15735/15735339.png"
    },
     {
        name:"Subhan",
        group:"PB306",
        age:19,
        img:"https://cdn-icons-png.flaticon.com/512/4003/4003435.png"
    },
     {
        name:"Tabriz",
        group:"PB306",
        age:20,
        img:"https://cdn-icons-png.flaticon.com/512/4804/4804680.png"
    }
]

const row=document.getElementsByClassName("row")[0]


for(let i=0;i<arr.length;i++){

row.innerHTML+=` <div class="col-3">
                <div class="card" style="width: 18rem;">
                    <img src="${arr[i].img}" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">${arr[i].name}</h5>
                        <p class="card-text">Group:${arr[i].group}</p>
                        <p class="card-text">Age:${arr[i].age}</p>
                    </div>
                </div>

            </div>`

}













// for(let i=0;i<arr.length;i++){

//     const li=document.createElement("li")
//     li.textContent=`Name: ${arr[i].name}  Age: ${arr[i].age}`

//     list.appendChild(li)

// }


// for(let i=0;i<arr.length;i++){


// console.log(`Name:${arr[i].name} Group:${arr[i].group}`)

// }

// for(let i=0;i<arr.length;i++){
//     console.log(arr[i]+5)
// }








