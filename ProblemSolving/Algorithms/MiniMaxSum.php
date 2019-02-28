
<?php
function miniMaxSum($arr) {
    $res=0;
    sort($arr);
    for ($i=0; $i < count($arr)-1; $i++) { 
        $res+=$arr[$i];
    }
    echo($res);
    $res=0;
    for ($i=1; $i < count($arr); $i++) { 
        $res+=$arr[$i];

    }
    echo(" " . $res);


}
miniMaxSum([1,2,3,1,2,3]);