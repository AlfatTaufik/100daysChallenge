<?php

function generateHashtag($str) {
    $hashtag = ucwords(trim($str));
    $strToArr = explode(' ', $hashtag);
    $arrToStr = implode('', $strToArr);
  
    if(empty($arrToStr) || strlen($arrToStr) >= 140 || strlen(trim($arrToStr)) == 0){
      return false;
    }
  
    return '#' . $arrToStr;
}

print_r(generateHashtag('coding'));
// output: #Coding