import React, { useState } from 'react'
import SeparateActor from './components/SeparateActor'
import SeparateGenre from './components/SeparateGenre'

export default function Page() {
    // these are the states for the function
    const [actorId, setActorId] = useState(0) // this contains the input for the actorId to be found
    const [actor, setActor] = useState(null) // this contains the data for the actor retrieved from the database
    const [actors, setActors] = useState(null) // this contains the data for all the actors
    const [genres, setGenres] = useState(null) // this contains the data for all the genres

    // get all actors form
    // handles the form submission - called when form button is clicked
    function handleSubmitForAllActors(e) {
        e.preventDefault() // prevents the page from reloading

        // gets the data from the database using JS fetch API
        return fetch(`https://sakilabackend20220809145429.azurewebsites.net/getnamesofallactors`, {
            method: "GET"
        })
            .then((response) => response.json())
            .then((data) => {
                console.log(data) // check data format in the console
                setActors(data) // set the actor retrieved from the database
            })
            .catch((err) => {
                console.log(err.message);
            });
    }

    function handleSubmitForGenres(e) {
        e.preventDefault() // prevents the page from reloading

        // gets the data from the database using JS fetch API
        return fetch(`https://sakilabackend20220809145429.azurewebsites.net/getgenrerevenues`, {
            method: "GET"
        })
            .then((response) => response.json())
            .then((data) => {
                console.log(data) // check data format in the console
                setGenres(data) // set the actor retrieved from the database
            })
            .catch((err) => {
                console.log(err.message);
            });
    }

    // get an actor by ID
    // handles the form submission - called when form button is clicked
    function handleSubmitForActorByID(e) {
        e.preventDefault() // prevents the page from reloading

        // gets the data from the database using JS fetch API
        return fetch(`https://sakilabackend20220809145429.azurewebsites.net/getactor/${actorId}`, {
            method: "GET"
        })
            .then((response) => response.json())
            .then((data) => {
                console.log(data) // check data format in the console
                setActor(data) // set the actor retrieved from the database
            })
            .catch((err) => {
                console.log(err.message);
            });
    }

    // handles the input change (used in the form text)- updated whenever the user changes something in the input field
    function handleChange(e) {
        setActorId(e.target.value) // sets the actorId to be used in the handleSubmit function above
    }

    return (
        <div>
            <h1>Get all actors</h1>
            <form>
                <button type="submit" onClick={handleSubmitForAllActors}>Find Actor</button>
            </form>
            {/* the {actor} is the props that are being passed to the seperate actor component */}
            {/* {<SeparateActor actor={actor} />}    */}
            {/* {actor.map(item => <SeparateActor actor={item} />)} */}
            <ul>            
                {actors && actors.map((item, index) => (
                <li key={index}>
                    <SeparateActor actor={item} />
                </li>
                ))}
            </ul>


            <h1>Get a specific actor by ID</h1>
            <form>
                <input type="text" value={actorId} onChange={handleChange} />
                <button type="submit" onClick={handleSubmitForActorByID}>Find Actor</button>
            </form>
            {/* the {actor} is the props that are being passed to the seperate actor component */}
            {/* {<SeparateActor actor={actor} />}    */}
            { actor && <SeparateActor actor={actor[0]} />}
            {/* <ul>            
                {actor && actor.map(item => (
                <li key={item.id}>
                    <SeparateActor actor={item[0]} />
                </li>
                ))}
            </ul> */}

            <h1>Get all genres</h1>
            <form>
                <button type="submit" onClick={handleSubmitForGenres}>Find All Genres</button>
            </form>
            {/* the {actor} is the props that are being passed to the seperate actor component */}
            {/* {<SeparateActor actor={actor} />}    */}
            {/* {actor.map(item => <SeparateActor actor={item} />)} */}
            <ul>        
                {/* {console.log("an array?: " + Array.isArray(genres))}   
                {console.log("what is the type?: " + typeof genres)} */}
                {genres && genres.topGenres.map((item, index) => (
                <li key={index}>
                    <SeparateGenre genre={item} />
                </li>
                ))}
            </ul>
        </div>
    )
}


// import React, { useState } from 'react'

// export default function Actor() {
//     // these are the states for the function
//     const [actorId, setActorId] = useState(0) // this contains the input for the actorId to be found
//     const [actor, setActor] = useState(null) // this contains the data for the actor retrieved from the database

//     // handles the form submission - called when form button is clicked
//     function handleSubmit(e) {
//         e.preventDefault() // prevents the page from reloading

//         // gets the data from the database using JS fetch API
//         return fetch(`https://sakilabackend20220809145429.azurewebsites.net/getactor/${actorId}`, {
//             method: "GET"
//         })
//             .then((response) => response.json())
//             .then((data) => {
//                 console.log(data) // check data format in the console
//                 setActor(data) // set the actor retrieved from the database
//             })
//             .catch((err) => {
//                 console.log(err.message);
//             });
//     }

//     // handles the input change - updated whenever the user changes something in the input field
//     function handleChange(e) {
//         setActorId(e.target.value) // sets the actorId to be used in the handleSubmit function above
//     }

//     return (
//         <div>
//             <h1>Enter Actor ID</h1>
//             <form>
//                 {/* <input type="text" value={actorId} onChange={handleChange} /> */}
//                 <input type="text" onChange={handleChange} value={actorId} />

//                 <button type="submit" onClick={handleSubmit}>Find Actor</button>

//             </form>
//             {actor && <p>{actor[0].firstName} {actor[0].lastName}</p>}
//         </div>
//     )
// }


// import React, { Component } from "react";

// class App extends Component {
//   constructor(props){
//     super(props);
//     this.state = {
//       items:[],
//       isLoaded:false,
//     }
//   }

//   // componentDidMount() {
//   //   fetch('https://sakilabackend20220809145429.azurewebsites.net/getactor/1', {
//   //     method: "GET"
//   //   })
//   //   .then(res => res.json())
//   //   .then(json => {
//   //     this.setState({
//   //       isLoaded:true,
//   //       items:json,
//   //     })
//   //   });
//   // }

//   fetchActorById() {
//     fetch('https://sakilabackend20220809145429.azurewebsites.net/getactor/1', {
//       method: "GET"
//     })
//     .then(res => res.json())
//     .then(json => {
//       this.setState({
//         isLoaded:true,
//         items:json,
//       })
//     });
//   }

//   render() {
//     let { isLoaded, items } = this.state;



//     if (!isLoaded) {
//       return <div>Loading...</div>;
//     }
//     else{
//       return (
//         <div className="App">
//           <ul>            
//             {items.map(item => (
//               <li key={item.id}>
//                 Firstname: {item.firstName} | Lastname: {item.lastName}
//               </li>
//             ))}
//           </ul>
//         </div>
//       )
//     }
//   }
// }

// export default App;
