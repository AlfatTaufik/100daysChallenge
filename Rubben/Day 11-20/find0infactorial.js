// function zeros (n) {
//   let count = 0;
//     for (let i = 5; n / i >= 1; i *= 5) {
//         count += Math.floor(n / i);
//     }
//     return count;
// }
// Simplified
function zeros(n) {
  return n/5 < 1 ? 0 : Math.floor(n/5) + zeros(n/5);
}
