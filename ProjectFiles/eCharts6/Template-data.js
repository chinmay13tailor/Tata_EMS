var dom = document.getElementById('container');
dom.style.backgroundColor = '#f0f0f0'; // Set background color
var myChart = echarts.init(dom, null, {
    renderer: 'canvas',
    useDirtyRect: false
});
var app = {};

var option;

option = {
    series: [
        {
            type: 'gauge',
            max: 70,
            progress: {
                show: true,
                width: 30
            },
            axisLine: {
                lineStyle: {
                    width: 20,
                    startAngle: 0 // Set the start angle to 0 degrees
                }
            },
            axisTick: {
                show: false
            },
            splitLine: {
                length: 5,
                lineStyle: {
                    width: 2,
                    color: '#999'
                }
            },
            axisLabel: {
                distance: 25,
                color: '#999',
                fontSize: 15
            },
            anchor: {
                show: true,
                showAbove: true,
                size: 25,
                itemStyle: {
                    borderWidth: 3
                }
            },
            title: {
                show: false
            },
            detail: {
                valueAnimation: true,
                fontSize: 40,
                offsetCenter: [0, '70%'],
                formatter: function (value) {
                    return value.toFixed(2);
                } // Closing curly brace for formatter function
            }, // Closing curly brace for detail object
            data: [
                parseFloat('$02')
            ]
        }
    ]
};


if (option && typeof option === 'object') {
    myChart.setOption(option);
}

window.addEventListener('resize', myChart.resize);
