let a = ["1", "2", "3", "4"];

let b = a
  .filter(n => {
    console.log(n);
    return true;
  })
  .map(n => {
    console.log(n);
    return n + "E";
  });
