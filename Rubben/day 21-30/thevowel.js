function encode(string) {
    let list = {
      "a": 1,
      "e": 2,
      "i": 3,
      "o": 4,
      "u": 5
    }
    let result = string.split("").map(char => list[char] || char).join("")
    
    return result
  }
  function decode(string) {
    let list = {
      "1": "a",
      "2": "e",
      "3": "i",
      "4": "o",
      "5": "u"
    }
    let result = string.split("").map(char => list[A] || char).join("")
    
    return result
  }
