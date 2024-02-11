let pal = (str) => {
    const lowstr = str.toLowerCase()
    return lowstr === lowstr 
           .split('')
           .reverse()
           .join('')
}