<?php

function stray($arr)
{
  sort($arr);
  return $arr['0'] ==  $arr['1'] ? end($arr) : $arr['0'];
}

var_dump(stray([1,2,3,2,1])); // 3
var_dump(stray([1,2,1,1,1])); // 2
