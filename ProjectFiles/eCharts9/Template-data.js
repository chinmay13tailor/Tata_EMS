var dom = document.getElementById('container');
var myChart = echarts.init(dom, null, {
    renderer: 'canvas',
    useDirtyRect: false,
    backgroundColor: '#f0f0f0'
});
var app = {};

var option;

let date =[];
let data = [];
for (let i = 1; i < 145; i++) { // Loop for 31 days
    date.push('Min' + i); // Pushing day labels into the array
    // data.push([Math.random() * 50 + 50, Math.random() * 60 + 60]); // Generate random data

}

option = {
    tooltip: {
        trigger: 'axis',
        position: function (pt) {
            return [pt[0], '10%'];
        }
    },
    title: {
        left: 'center',
        text: 'Average Current',
         textStyle: {
            fontWeight: 'bold'
        }
    },
    toolbox: {
        feature: {
            dataZoom: {
                yAxisIndex: 'none'
            },
            restore: {},
            saveAsImage: {}
        }
    },
    xAxis: {
        type: 'category',
        boundaryGap: false,
        data: date,
        textStyle: {
            fontWeight: 'bold'
        }
    },
    yAxis: {
        type: 'value',
        boundaryGap: [0, '100%'],
        textStyle: {
            fontWeight: 'bold'
        }

    },
    dataZoom: [
        {
            type: 'inside',
            start: 0,
            end: 10
        },
        {
            start: 0,
            end: 10
        }
    ],
    series: [
        {
            name: 'Average Current',
            type: 'line',
            symbol: 'none',
            sampling: 'lttb',
            itemStyle: {
                color: 'rgb(255, 70, 131)'
            },
            areaStyle: {
                color: new echarts.graphic.LinearGradient(0, 0, 0, 1, [
                    {
                        offset: 0,
                        color: 'rgb(255, 158, 68)'
                    },
                    {
                        offset: 1,
                        color: 'rgb(255, 70, 131)'
                    }
                ])
            },
            data: [$001, $002, $003, $004, $005, $006, $007, $008, $009, $010, $011, $012, $013, $014, $015, $016, $017, $018, $019, $020, $021, $022, $023, $024, $025, $026, $027, $028, $029, $030, $031,
                $032, $033, $034, $035, $036, $037, $038, $039, $040, $041, $042, $043, $044, $045, $046, $047, $048, $049, $050, $051, $052, $053, $054, $055, $056, $057, $058, $059, $060, $061, $062,
                $063, $064, $065, $066, $067, $068, $069, $070, $071, $072, $073, $074, $075, $076, $077, $078, $079, $080, $081, $082, $083, $084, $085, $086, $087, $088, $089, $090, $091, $092, $093,
                $094, $095, $096, $097, $098, $099, $100, $101, $102, $103, $104, $105, $106, $107, $108, $109, $110, $111, $112, $113, $114, $115, $116, $117, $118, $119, $120,
                $121, $122, $123, $124, $125, $126, $127, $128, $129, $130, $131, $132, $133, $134, $135, $136, $137, $138, $139, $140, $141, $142, $143, $144]
        }
    ],
    backgroundColor: '#f0f0f0'
};

if (option && typeof option === 'object') {
    myChart.setOption(option);
}

window.addEventListener('resize', myChart.resize);
