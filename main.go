package main

/*
#include <stdlib.h>

typedef void (*CallbackDelegate)();

static inline void RegisterCallback(CallbackDelegate callback) {
    callback();
}
*/
import "C"

func main() {
}

//export RegisterCallback2
func RegisterCallback2(callback C.CallbackDelegate) {
	C.RegisterCallback(callback)
}