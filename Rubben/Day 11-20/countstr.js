// function count(str) {
//     let obj = {}
//     for (let index = 0; index < str.length; index++) {
//         const element = str[index];
//         if(!obj[element]) {
//             obj[element] =0
//         }
//         obj[element]++
//     }
//     return obj
// }

function count (string) {  
    let count = {};
    string.split('').forEach(function(s) {
       count[s] ? count[s]++ : count[s] = 1;
    });
    return count;
  }