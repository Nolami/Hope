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

<script>
var Text = document.getElementById('Text');

function updateTextColor() {
    var TePos = text.Element.getBoundingClientRect(),left;

    var brown = '#491810';
    var pink = '#c02e4c'
    var white = '#ffffff'

    var TeCo;
    if (TePos < window.innerWidth / 3) {
        TeCo = brown;
    } else if (TePos < (window.innderWidth * 2) / 3) {
        TeCo = pink;
    } else {
        TeCo = white;
    }
    textElement.style.color = TeCo;
}



//</script>//window.addEventListener('scroll', updateTextColor); 
//window.addEventListener('resize', updateTextColor); 
//updateTextColor();

