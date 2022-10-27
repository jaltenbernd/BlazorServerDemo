

window.returnArrayAsync = () => {
    DotNet.invokeMethodAsync('BlazorServerDemo', 'ReturnArrayAsync')
        .then(data => {
            alert(data);
        });
};


window.sayHello1 = (dotNetHelper) => {
    return dotNetHelper.invokeMethodAsync('GetHelloMessage');
};