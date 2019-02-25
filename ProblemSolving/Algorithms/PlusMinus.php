<?php
// https://www.hackerrank.com/challenges/plus-minus/problem

$arr= array(2,1,2,1,-5,3,-3,0);

function plusMinus($arr) {
    $neg=0;
    $pos=0;
    $zero=0;

    foreach ($arr as $key => $value) {
        if($value===0){
            $zero++;
            
        }
        if($value > 0){
            $pos++;
        }
        if($value < 0){
            $neg++;
        }

    }

    echo(number_format( $pos /count($arr),6 ). PHP_EOL);
    echo(number_format( $neg /count($arr),6 ). PHP_EOL);
    echo(number_format( $zero /count($arr),6 ). PHP_EOL);

}

plusMinus($arr);

