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

    legend: {}, // Configure the legend (usually for chart series names)
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
            name: 'Frequency', // Series name
            type: 'line', // Change chart type to line
            stack: 'total',
            Refresh: 'Auto', // Stack bars in the 'total' group
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
            data: [$01, $02, $03, $04, $05, $06, $07, $08, $09, $10, $11, $12, $13, $14, $15, $16, $17, $18, $19, $20, $21, $22, $23, $24, $25, $26, $27, $28, $29, $30, $31]
        },
       
        // Similar configurations for other series...
    ]
};

// Apply CSS class to the chart container
dom.classList.add('chart-container');

if (option && typeof option === 'object') { // Check if the "option" object is valid
    myChart.setOption(option); // Apply the chart configuration options
}

window.addEventListener('resize', myChart.resize); // Add a resize event listener to handle chart resizing
