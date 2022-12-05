const btnreq = document.getElementById("btntosend").addEventListener("click" , (e)=>{
    console.log("kliknieto");

    let inputtext = 'https://localhost:7167/api/';

    const endofinput = document.querySelector("#inp").value;

    inputtext += endofinput;

    //const rangeofid = 0 < 

    const  endofinputisnum = inputtext.slice(-1);

    const endofinputisnumconv = parseInt(endofinputisnum);

    console.log(endofinputisnumconv);

    console.log(endofinputisnumconv + 1);

    if(endofinputisnumconv > 0 && endofinputisnumconv < 50){
        console.log(endofinputisnumconv);
            //console.log("fdfdfd" , endofinputisnumconv);
    }

    console.log(`https://localhost:7167/api/GreatOldOnes/${endofinputisnumconv}`);

    const listoflinks = ["https://localhost:7167/api/GreatOldOnes" , `https://localhost:7167/api/GreatOldOnes/${endofinputisnumconv}` , "https://localhost:7167/api/GreatOnes" , `https://localhost:7167/api/GreatOnes/${endofinputisnumconv}` , "https://localhost:7167/api/OuterOnes" , `https://localhost:7167/api/OuterOnes/${endofinputisnumconv}`  ,  "https://localhost:7167/api/Stories" ,  `https://localhost:7167/api/Stories/${endofinputisnumconv}`];


    const linksofgreatoldones = ["https://localhost:7167/api/GreatOldOnes" , `https://localhost:7167/api/GreatOldOnes/${endofinputisnumconv}`];

    const linksofgreatones = ["https://localhost:7167/api/GreatOnes" , `https://localhost:7167/api/GreatOnes/${endofinputisnumconv}`];

    const linksofouterones = ["https://localhost:7167/api/OuterOnes" , `https://localhost:7167/api/OuterOnes/${endofinputisnumconv}`];

    const listofstories = ["https://localhost:7167/api/Stories" ,  `https://localhost:7167/api/Stories/${endofinputisnumconv}`];

    var exampletext = document.getElementById("exampletext");

    console.log(listoflinks[1]);

    console.log(inputtext);

//Dziala jbc inputtext == 'https://localhost:7167/api/GreatOldOnes'

    if(listoflinks.includes(inputtext)){

        exampletext.innerHTML= "Example data of " + "<br>" + inputtext;
        let spacefordata = document.getElementById("pid");

        spacefordata.innerHTML = "";

        if(linksofgreatoldones.includes(inputtext)){
            fetch(inputtext)
        .then(res=>{
            return res.json();
        })

        .then(data =>{
            console.log(data);
            if(Array.isArray(data)){
                if(data.length > 1){
                    let link = `<a href = '${inputtext}'>'${inputtext}'</a>`;
                    document.getElementById("pid").insertAdjacentHTML('beforeend',link  )
                }
                else{
                    data.forEach(greatoldone => {
                        let markup = "Id : " + `${greatoldone.id}` + "<br>";
                        markup += "Name : " + `${greatoldone.name}` + "<br>";
                        markup += "First Apperance : " + greatoldone.firstAppearance + "<br>";
                        markup += "Dangerous Scale Out Of Ten : " + greatoldone.dangerousScaleOutOfTen + "<br>";
                        markup += "Where Currently is : " + greatoldone.whereItCurrentlyIs + "<br>";
                        markup += "Stage : " + greatoldone.stage;
                        console.log(markup);
                        document.getElementById("pid").insertAdjacentHTML('beforeend',markup)
                    });
                }
                
            }
            else{
                 
                let markup = "Id : " + `${data.id}` + "<br>";
                markup += "Name : " + `${data.name}` + "<br>";
                markup += "First Apperance : " + data.firstAppearance + "<br>";
                markup += "Dangerous Scale Out Of Ten : " + data.dangerousScaleOutOfTen + "<br>";
                markup += "Where Currently is : " + data.whereItCurrentlyIs + "<br>";
                markup += "Stage : " + data.stage;
                console.log(markup);
                document.getElementById("pid").insertAdjacentHTML('beforeend',markup)
      
            }
            // console.log(data);
            // sprawdzic jesli data to array to foreach jak nie to tak jak teraz
            //     const markup = `${data.name}`;
            //     console.log(markup);
            //     document.getElementById("pid").insertAdjacentHTML('beforeend',markup)

            //https://www.tutorialrepublic.com/faq/how-to-check-if-object-is-an-array-in-javascript.php#:~:text=Answer%3A%20Use%20the%20Array.,an%20array%3B%20otherwise%20returns%20false%20.

        
        })

        .catch(error => console.log(error));
    }

    else if(listofstories.includes(inputtext)){
        fetch(inputtext)
        .then(res=>{
            return res.json();
        })

        .then(data =>{
            console.log(data);
            if(Array.isArray(data)){
                    if(data.length > 1){
                        let link = `<a href = '${inputtext}'>'${inputtext}'</a>`;
                        document.getElementById("pid").insertAdjacentHTML('beforeend',link  )
                    }
                    else{
                        data.forEach(story => {
                  
                            let markup = "Id : " + `${story.id}` + "<br>";
                            markup += "Name : " +  `${story.name}` + "<br>";
                            markup += "Date" + story.creationTime + "<br>";
                            console.log(markup);
                            document.getElementById("pid").insertAdjacentHTML('beforeend',markup)
                           
                        });
                    }
                  
               
              
            }
            else{
                
                let markup = "Name : " +  `${data.name}` +"<br>";
                markup += "Date :" + data.creationTime;
                console.log(markup);
                document.getElementById("pid").insertAdjacentHTML('beforeend',markup)
      
            }
        })

        .catch(error => console.log(error));
    }



    else if(linksofgreatones.includes(inputtext)){
        fetch(inputtext)
        .then(res=>{
            return res.json();
        })

        .then(data =>{
            console.log(data);
            if(Array.isArray(data)){
                if(data.length > 1){
                    let link = `<a href = '${inputtext}'>'${inputtext}'</a>`;
                    document.getElementById("pid").insertAdjacentHTML('beforeend',link  )
                }
                else{
                    data.forEach(greatones => {
                        let markup = "Id : " + `${greatones.id}` + "<br>";
                        markup += "Name : " +  `${greatones.name}` + "<br>";
                        markup += "Class Name : " + greatones.className + "<br>";
                        markup += "First Appearance : " +  greatones.firstAppearance + "<br>";
                        markup += "Dangerous Scale Out Of Ten : " + greatones.dangerousScaleOutOfTen + "<br>";
                        console.log(markup);
                        document.getElementById("pid").insertAdjacentHTML('beforeend',markup)
                    });
                }
               
            }
            else{
                let markup = "Name : " +  `${data.name}`;
                markup += "Class Name : " + data.className + "<br>";
                markup += "First Appearance : " +  data.firstAppearance + "<br>";
                markup += "Dangerous Scale Out Of Ten : " + data.dangerousScaleOutOfTen + "<br>";
                console.log(markup);
                document.getElementById("pid").insertAdjacentHTML('beforeend',markup)
      
            }
        })

        .catch(error => console.log(error));
    }

 //todo



    else if(linksofouterones.includes(inputtext)){
        fetch(inputtext)
        .then(res=>{
            return res.json();
        })

        .then(data =>{
            console.log(data);
            if(Array.isArray(data)){
                if(data.length > 1){
                    let link = `<a href = '${inputtext}'>'${inputtext}'</a>`;
                    document.getElementById("pid").insertAdjacentHTML('beforeend',link  )
                }
                else{
                    data.forEach(outerones => {
                        let markup = "Id : " + `${outerones.id}` + "<br>";
                        markup += "Name : " + `${outerones.name}` + "<br>";
                        markup += "Powers : " + outerones.powers + "<br>";
                        markup += "First Appearance : " +  outerones.firstAppearance + "<br>";
                        markup += "Dangerous Scale Out Of Ten : " + outerones.dangerousScaleOutOfTen + "<br>";
                        console.log(markup);
                        document.getElementById("pid").insertAdjacentHTML('beforeend',markup)
                    });
                }
               
            }
            else{
                let markup = "Name : " + data.name + "<br>";
                markup += "Powers : " + data.powers + "<br>";
                markup += "First Appearance : " +  data.firstAppearance + "<br>";
                markup += "Dangerous Scale Out Of Ten : " + data.dangerousScaleOutOfTen + "<br>";
                console.log(markup);
                document.getElementById("pid").insertAdjacentHTML('beforeend',markup)
      
            }
        })

        .catch(error => console.log(error));
    }

    }   
});

/*
TODO
*/