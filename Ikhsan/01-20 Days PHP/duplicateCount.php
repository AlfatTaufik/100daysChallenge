<?php

function duplicateCount($text) {
  $arr = str_split(strtolower($text));
  
  $duplicates = array_filter(array_count_values($arr), function($n) {
    return $n > 1;
  });
  
  $dupCount = count($duplicates);
  
  return $dupCount;
}

var_dump(duplicateCount("abcde")); // 0
var_dump(duplicateCount("aabbcde")); // 2
var_dump( duplicateCount("Jokosu")); // 1