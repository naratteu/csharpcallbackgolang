package main

/*
typedef void (*Action)();
static void invoke(Action callback) { callback(); }

typedef void (*Action2)(int i);
static void invoke2(Action2 callback, int i) { callback(i); }

typedef int (*Func)();
static int invoke3(Func callback) { return callback(); }
*/
import "C"

func main() {}

//export Invoke
func Invoke(callback C.Action) {
	C.invoke(callback)
}

//export Invoke2
func Invoke2(callback C.Action2, i C.int) {
	C.invoke2(callback, i)
}

//export Invoke3
func Invoke3(callback C.Func) C.int {
	return C.invoke3(callback)
}