//Quick sort in javascript
function quickSort(arr) {
    if (arr.length < 1) return arr
    const pivot = arr[0]
    const left = arr.filter(x => x < pivot)
    const right = arr.filter(x => x > pivot)
    
    return [...quickSort(left), pivot, ...quickSort(right)]
}
let arr = [28,-21,-4,-83,-5,-46,-95,-81,-23,-8,-53,-24,-9,-82,-98]
console.info(quickSort(arr))