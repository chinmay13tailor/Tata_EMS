var dom = document.getElementById('container');
var myChart = echarts.init(dom, null, {
    renderer: 'canvas',
    useDirtyRect: false
});
var app = {};

var option;

var xAxisData = [];
var data1 = [];
var data2 = [];
for (var i = 1; i < 32; i++) {
    xAxisData.push('Day' + i);
   // data1.push(22);//(Math.sin(i / 5) * (i / 5 - 10) + i / 6) * 5);
    data2 = ["$01"];
}
option = {
    title: {
        text: 'Bar Animation Delay'
    },
    legend: {
        data: ['Consumption']
    },
    toolbox: {
        // y: 'bottom',
        feature: {
            magicType: {
                type: ['stack']
            },
            dataView: {},
            saveAsImage: {
                pixelRatio: 2
            }
        }
    },
    tooltip: {},
    xAxis: {
        data: xAxisData,
        splitLine: {
            show: false
        }
    },
    yAxis: {},
    series: [
        {
            name: 'Consumption',
            type: 'bar',
            data: data1,
            emphasis: {
                focus: 'series'
            },
            animationDelay: function (idx) {
                return idx * 10;
            }
        },
        
    ],
    animationEasing: 'elasticOut',
    animationDelayUpdate: function (idx) {
        return idx * 5;
    }
};

if (option && typeof option === 'object') {
    myChart.setOption(option);
}

window.addEventListener('resize', myChart.resize);