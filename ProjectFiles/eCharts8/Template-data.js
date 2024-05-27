var dom = document.getElementById('container');
var myChart = echarts.init(dom, null, {
    renderer: 'canvas',
    useDirtyRect: false
});
var app = {};

var option;

option = {
    graphic: {
        elements: [
            {
                type: 'text',
                left: 'center',
                top: '5%',
                style: {
                    text: 'TATA MOTORS',
                    fontSize: 80,
                    fontWeight: 'bold',
                    lineDash: [0, 200],
                    lineDashOffset: 0,
                    fill: 'transparent',
                    stroke: '#000',
                    lineWidth: 1
                },
                keyframeAnimation: {
                    duration: 20000,
                    loop: true,
                    keyframes: [
                        {
                            percent: 0.1,
                            style: {
                                fill: 'transparent',
                                lineDashOffset: 200,
                                lineDash: [200, 0]
                            }
                        },
                        {
                            // Stop for a while.
                            percent: 0.3,
                            style: {
                                fill: 'transparent'
                            }
                        },
                        {
                            percent: 0.8,
                            style: {
                                fill: 'black'
                            }
                        }
                    ]
                }
            },
            // New text element
            {
                type: 'text',
                left: 'center',
                top: '40%',
                style: {
                    text: 'ENERGY MONITORING SYSTEM',
                    fontSize: 80,
                    fontWeight: 'bold',
                    lineDash: [0, 200],
                    lineDashOffset: 0,
                    fill: 'transparent',
                    stroke: '#000',
                    lineWidth: 1
                },
                keyframeAnimation: {
                    duration: 20000,
                    loop: true,
                    keyframes: [
                        {
                            percent: 0.1,
                            style: {
                                fill: 'transparent',
                                lineDashOffset: 200,
                                lineDash: [200, 0]
                            }
                        },
                        {
                            // Stop for a while.
                            percent: 0.3,
                            style: {
                                fill: 'transparent'
                            }
                        },
                        {
                            percent: 0.8,
                            style: {
                                fill: 'black'
                            }
                        }
                    ]
                }
            },
            {
                type: 'text',
                left: 'center',
                top: '80%',
                style: {
                    text: 'Please Login',
                    fontSize: 40,
                    fontWeight: 'bold',
                    lineDash: [0, 200],
                    lineDashOffset: 0,
                    fill: 'transparent',
                    stroke: '#000',
                    lineWidth: 1
                },
                keyframeAnimation: {
                    duration: 20000,
                    loop: true,
                    keyframes: [
                        {
                            percent: 0.1,
                            style: {
                                fill: 'transparent',
                                lineDashOffset: 200,
                                lineDash: [200, 0]
                            }
                        },
                        {
                            // Stop for a while.
                            percent: 0.3,
                            style: {
                                fill: 'transparent'
                            }
                        },
                        {
                            percent: 0.8,
                            style: {
                                fill: 'black'
                            }
                        }
                    ]
                }
            }
        ]
    }
};

if (option && typeof option === 'object') {
    myChart.setOption(option);
}

window.addEventListener('resize', myChart.resize);