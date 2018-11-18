let i = 0;
    
    let start = Date.now();
    
    function count() {
    
      // do a piece of the heavy job (*)
      do {
        i++;
        //console.log(i % 1e6);
      } while (i % 1e6 != 0);
    
      if (i == 1e9) {
        console.log("Done in " + (Date.now() - start) + 'ms');
      } else {
        setTimeout(count, 0); // schedule the new call (**)
      }
    
    }
    
    count();
    console.log(1000 % 100000,1e6);