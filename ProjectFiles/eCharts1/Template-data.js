

var dom = document.getElementById('container'); // Get the DOM element with the id "container"

setInterval(function () { myChart.setOption(option); }, 10000);
var myChart = echarts.init(dom, null,
    { // Initialize an ECharts chart
        renderer: 'canvas', // Use the canvas renderer
        useDirtyRect: false // Disable dirty rect optimization
    });
var app = {}; // Create an empty JavaScript object

var option; // Declare a variable named "option" for chart configuration

option = { // Define the chart configuration options
    tooltip: { // Configure the tooltip
        trigger: 'axis', // Trigger the tooltip on axes
        axisPointer: { // Configure the axis pointer for the tooltip
            type: 'line' // Use 'shadow' type for the axis pointer; it can also be 'line' or 'shadow'
        }
    },
    legend: {
        data: ['V_RPhase', 'V_YPhase', 'V_BPhase'] // Specify legend data
    },
    grid: { // Configure the grid layout
        left: '3%', // Left margin
        right: '4%', // Right margin
        bottom: '3%', // Bottom margin
        containLabel: true // Allow labels to be contained within the grid
    },
    yAxis: { // Configure the X-axis
        type: 'value', // Use a numeric X-axis
        axisLabel: { // Configure the axis label
            textStyle: { // Configure text style for the axis label
                color: '#000000', // Set text color to black
                fontWeight: 'bold' // Set font weight to bold
            }
        }
    },
    xAxis: { // Configure the Y-axis
        type: 'category', // Use a category (text) Y-axis
        data: ['Day 01', 'Day 02', 'Day 03', 'Day 04', 'Day 05', 'Day 06', 'Day 07', 'Day 08', 'Day 09', 'Day 10', 'Day 11', 'Day 12', 'Day 13', 'Day 14', 'Day 15', 'Day 16', 'Day 17', 'Day 18', 'Day 19', 'Day 20', 'Day 21', 'Day 22', 'Day 23', 'Day 24', 'Day 25', 'Day 26', 'Day 27', 'Day 28', 'Day 29', 'Day 30', 'Day 31'], // Specify Y-axis data labels
        axisLabel: { // Configure the axis label
            textStyle: { // Configure text style for the axis label
                color: '#000000', // Set text color to black
                fontWeight: 'bold' // Set font weight to bold
            }
        }
    },
    series: [ // Configure chart series data
        {
            name: 'V_RPhase', // Series name
            type: 'line',
            label: { // Configure labels for bars
                show: true // Show labels
            },
            emphasis: { // Configure emphasis settings for bars
                focus: 'series', // Emphasize the entire series on interaction
                itemStyle: { // Modify item style on emphasis (hover)
                    borderColor: '#000000', // Set border color to black
                    borderWidth: 2 // Set border width
                }
            },
            itemStyle: {
                color: '#ff0000', // Solid color for the bars
                borderRadius: [5, 5, 0, 0] // Set the border radius for the bars (top-left, top-right, bottom-right, bottom-left)
            },

// Change chart type to line
            data: [$01, $02, $03, $04, $05, $06, $07, $08, $09, $10, $11, $12, $13, $14, $15, $16, $17, $18, $19, $20, $21, $22, $23, $24, $25, $26, $27, $28, $29, $30, $31] // Placeholder for data points
        },
        {
            name: 'V_YPhase', // Series name
            type: 'line',
            label: { // Configure labels for bars
                show: true // Show labels
            },
            emphasis: { // Configure emphasis settings for bars
                focus: 'series', // Emphasize the entire series on interaction
                itemStyle: { // Modify item style on emphasis (hover)
                    borderColor: '#000000', // Set border color to black
                    borderWidth: 2 // Set border width
                }
            },
            itemStyle: {
                color: '#ffff00', // Solid color for the bars
                borderRadius: [5, 5, 0, 0] // Set the border radius for the bars (top-left, top-right, bottom-right, bottom-left)
            },
// Change chart type to line
            data: [$32, $33, $34, $35, $36, $37, $38, $39, $40, $41, $42, $43, $44, $45, $46, $47, $48, $49, $50, $51, $52, $53, $54, $55, $56, $57, $58, $59, $60, $61, $62] // Placeholder for data points
        },
        {
            name: 'V_BPhase', // Series name
            type: 'line',
            label: { // Configure labels for bars
                show: true // Show labels
            },
            emphasis: { // Configure emphasis settings for bars
                focus: 'series', // Emphasize the entire series on interaction
                itemStyle: { // Modify item style on emphasis (hover)
                    borderColor: '#000000', // Set border color to black
                    borderWidth: 2 // Set border width
                }
            },
            itemStyle: {
                color: '#0fafff', // Solid color for the bars
                borderRadius: [5, 5, 0, 0] // Set the border radius for the bars (top-left, top-right, bottom-right, bottom-left)
            },
// Change chart type to line
            data: [$63, $64, $65, $66, $67, $68, $69, $70, $71, $72, $73, $74, $75, $76, $77, $78, $79, $80, $81, $82, $83, $84, $85, $86, $87, $88, $89, $90, $91, $92, $93] // Placeholder for data points
        }
        // Similar configurations for other series...
    ]
};

// Sort the series data arrays based on their sum
var seriesData = option.series.map(function (series) {
    return {
        name: series.name,
        sum: series.data.reduce((acc, curr) => acc + curr, 0)
    };
});

seriesData.sort(function (a, b) {
    return b.sum - a.sum;
});

// Reorder the series based on sorted data
option.series = seriesData.map(function (item) {
    return option.series.find(function (series) {
        return series.name === item.name;
    });
});

// Apply CSS class to the chart container
dom.classList.add('chart-container');

if (option && typeof option === 'object') { // Check if the "option" object is valid
    myChart.setOption(option); // Apply the chart configuration options
}

window.addEventListener('resize', function () {
    if (myChart) {
        myChart.resize(); // Resize the chart when the window size changes
    }
}); // Add a resize event listener to handle chart resizing
