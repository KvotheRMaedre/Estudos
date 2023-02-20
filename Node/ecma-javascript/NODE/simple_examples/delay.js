const hello = delay => {
    console.log("Hello after " + delay + " seconds");
}

setTimeout(hello, 4 * 1000, '4');
setTimeout(hello, 8 * 1000, '8');