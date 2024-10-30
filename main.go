package main

/*
typedef void (*Action)();
static void invoke(Action callback) { callback(); }
*/
import "C"

func main() {}

//export Invoke
func Invoke(callback C.Action) {
	C.invoke(callback)
}