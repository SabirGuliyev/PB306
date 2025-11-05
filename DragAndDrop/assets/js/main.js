// const form = document.querySelector("#studentInfo")

// const nameInput = document.querySelector("#name")
// const surnameInput = document.querySelector("#surname")
// const ageInput = document.querySelector("#age")

// const tbody = document.querySelector("#studentTable tbody")


// let btns = document.querySelectorAll(".delete-btn");



// function CreateBtnEvents() {

//     for (let i = 0; i < btns.length; i++) {
//         btns[i].addEventListener("click", (e) => {
//             e.target.closest("tr").remove();

//         })
//     }

// }


// function RemoveRow(event){

//    event.target.parentElement.parentElement.remove();
// //    row.remove();
// }
// // CreateBtnEvents();

// // tbody.addEventListener("change",()=>{
// //     CreateBtnEvents()
// // })

// form.addEventListener("submit", (e) => {
//     e.preventDefault()
//     // CreateBtnEvents()


//     tbody.innerHTML += ` <tr>
//                 <td>${nameInput.value.trim()}</td>
//                 <td>${surnameInput.value.trim()}</td>
//                 <td>${ageInput.value}</td>
//                 <td><button onclick="RemoveRow(event)" class="delete-btn" style="background-color: red;">X</button></td>
//             </tr>`

//     // CreateBtnEvents()


//     // nameInput.value=""
//     // surnameInput.value=""
//     // ageInput.value=""
//     form.reset();


// })



const todo = document.querySelector("#todo")
const doing = document.querySelector("#doing")
const done = document.querySelector("#done")

const trash=document.querySelector(".cus-trash")

let dragItem=null;

const items = document.querySelectorAll(".cus-item")


for (let i = 0; i < items.length; i++) {
    items[i].addEventListener("dragstart", (e) => {
        e.target.style.opacity = "70%";

        e.target.classList.add("drag-item")
        dragItem=e.target;
        
    })

     items[i].addEventListener("dragend", (e) => {
        e.target.style.opacity = "100%";
        e.target.classList.remove("drag-item")
    })
}


todo.addEventListener("dragenter",()=>{
    todo.appendChild(dragItem);
   
})
doing.addEventListener("dragenter",()=>{
    doing.appendChild(dragItem);
   

})
done.addEventListener("dragenter",()=>{
    done.appendChild(dragItem);
   

})



todo.addEventListener("dragleave",()=>{
    todo.appendChild(dragItem);
    
})
doing.addEventListener("dragleave",()=>{
    doing.appendChild(dragItem);
   

})
done.addEventListener("dragleave",()=>{
    done.appendChild(dragItem);
    

})


trash.addEventListener("dragenter",()=>{
    dragItem.style.display="none";
})

trash.addEventListener("dragleave",()=>{
    dragItem.style.display="block";
})

trash.addEventListener("dragover",(e)=>{
e.preventDefault()
})

trash.addEventListener("drop",()=>{



    var result=window.confirm("are you sure?")

    if(result){
    dragItem.remove()

    }
    else{
        dragItem.style.display="block";
    }
})







// todo.addEventListener("dragover",(e)=>{
// e.preventDefault()

// todo.style.borderStyle="dashed";
// })

// todo.addEventListener("drop",(e)=>{
//   e.target.appendChild(dragItem)
// })


