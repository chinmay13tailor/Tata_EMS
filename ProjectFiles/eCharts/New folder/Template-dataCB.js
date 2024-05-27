var chartDom = document.getElementById('container');
var myChart = echarts.init(chartDom, null, {
    renderer: 'canvas',
    useDirtyRect: false
});

var option;

option = {
    title: {
        text: 'Bar Animation Delay',
        textStyle: {
            color: '#333',
            fontFamily: 'Arial, sans-serif',
            fontSize: 24,
            fontWeight: 'bold'
        }
    },
    legend: {
        data: ['bar'],
        textStyle: {
            color: '#666',
            fontSize: 16,
            fontWeight: 'normal'
        }
    },
    grid: {
        left: '5%',
        right: '5%',
        bottom: '8%',
        containLabel: true
    },
    toolbox: {
        feature: {
            saveAsImage: {
                pixelRatio: 2
            }
        },
        iconStyle: {
            normal: {
                borderColor: '#666'
            }
        }
    },
    tooltip: {
        trigger: 'axis',
        axisPointer: {
            type: 'shadow'
        }
    },
    xAxis: {
        type: 'category',
        data: ['DAY 01', 'DAY 02', 'DAY 03', 'DAY 04', 'DAY 05', 'DAY 06', 'DAY 07', 'DAY 08', 'DAY 09', 'DAY 10', 'DAY 11', 'DAY 12', 'DAY 13', 'DAY 14', 'DAY 15', 'DAY 16', 'DAY 17', 'DAY 18', 'DAY 19', 'DAY 20', 'DAY 21', 'DAY 22', 'DAY 23', 'DAY 24', 'DAY 25', 'DAY 26', 'DAY 27', 'DAY 28', 'DAY 29', 'DAY 30', 'DAY 31'],
        axisLabel: {
            color: '#666'
        }
    },
    yAxis: {
        type: 'value',
        axisLine: {
            lineStyle: {
                color: '#666'
            }
        },
        axisLabel: {
            color: '#666'
        },
        splitLine: {
            lineStyle: {
                color: ['#eee']
            }
        }
    },

    series: [{
        name: 'consumption',
        type: 'bar',
        data: [50, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        emphasis: {
            focus: 'series'
        },
        animationDelay: function (idx) {
            return idx * 10;
        },
        itemStyle: {
            color: new echarts.graphic.LinearGradient(0, 0, 0, 1, [{
                offset: 0,
                color: '#5AB3E6'
            },
            {
                offset: 0.5,
                color: '#7AD0E0'
            },
            {
                offset: 1,
                color: '#A8DBDC'
            }
            ])
        },
        animationEasing: 'cubicInOut'
    }],
    animationEasing: 'elasticOut',
    animationDelayUpdate: function (idx) {
        return idx * 5;
    }
};

if (option && typeof option === 'object') {
    myChart.setOption(option);
}

window.addEventListener('resize', function () {
    myChart.resize();
});
