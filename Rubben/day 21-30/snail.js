function snail(array) {
  let result = [];

  while (array.length > 0) {
    result.push(...array.shift());
    result.push(...array.map((row) => row.pop()));
    array.reverse().map((row) => row.reverse());
    console.log(array);
    if (array.length > 0) {
      result = result.concat(snail(array));
    }
  }
  return result;
}