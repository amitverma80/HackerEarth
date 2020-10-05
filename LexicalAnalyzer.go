package main

import (
    "fmt"
    "strings"
)

func main(){

    var N int
    var variable string

    fmt.Scanf("%d", &N)

    arr:=make([]string, N)

    result:=0

    for counter:=0;counter<N;counter++{
        fmt.Scanf("%s", &variable)

        tempArr := strings.Split(variable, "=")       

        if elementIndex(arr, tempArr[0])==-1{
            arr[counter]=tempArr[0]
            result++
        }
    }

    fmt.Println(result)
}

func elementIndex(arr []string, ele string) int{
    for i,e:=range arr{
        if e == ele{
            return i
        }
    }
    return -1
}

