
class GreetingHelpers {
    static dotNetHelper;

    static setDotNetHelper(value) {
        GreetingHelpers.dotNetHelper = value;
    }

    static async sayHello() {
        const msg = await GreetingHelpers.dotNetHelper.invokeMethodAsync('GetHelloMessage2');
        alert(`Message from .NET: "${msg}"`);
    }

    static async welcomeVisitor() {
        const msg = await GreetingHelpers.dotNetHelper.invokeMethodAsync('GetWelcomeMessage');
        alert(`Message from .NET: "${msg}"`);
    }
}

window.GreetingHelpers = GreetingHelpers;
