var Text = document.getElementId('text')

function updateTextColor() {
    var Pos = window.scrollY;

    var red = Math.sin(scrollPosition * 0.02) * 127 + 128;
    var green = Math.sin(scrollPosition * 0.03) * 127 + 128
    var blue = Math.sin(scrollPosition * 0.04) * 127 + 128;

    var textColor = "#" + Math.round(red).toString(16).padStart(2, '0') +
                        Math.round(green).toString(16).padStart(2, '0') +
                        Math.round(red).toString(16).padStart(2, '0');
    
    textElement.style.color = textColor;
}

window.addEventListener('scroll', updateTextColor)
updateTextColor();