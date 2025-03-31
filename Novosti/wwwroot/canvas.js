
window.getCanvasContext = (canvas) => {
    if (!canvas) {
        console.error("Canvas не найден");
        return null;
    }
    return canvas.getContext('2d');
};

window.clearCanvas = (context) => {
    context.clearRect(0, 0, 400, 400);
};

window.drawRect = (context, x, y, width, height, color = 'green') => {
    context.fillStyle = color;
    context.fillRect(x, y, width, height);
};

window.addKeyDownListener = (dotNetHelper) => {
    window.addEventListener('keydown', (event) => {
        dotNetHelper.invokeMethodAsync('OnKeyDown', event.key);
    });
};

window.removeKeyDownListener = () => {
    window.removeEventListener('keydown', this.onKeyDown);
};
