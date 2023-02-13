const webpack = require('webpack');
const path = require('path');
const { VueLoaderPlugin } = require('vue-loader');
const TerserPlugin = require("terser-webpack-plugin");
const config = {
    mode:"development",
    entry: './wwwroot/js/Page/index.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/assets/bundles/js'),
        filename: 'index.js'
    },
    module: {
        rules: [
            {
                test: /\.vue$/,
                loader: 'vue-loader'
            },
            {
                test: /\.js$/,
                use: 'babel-loader',
                exclude: /node_modules/
            },
            {
                test: /\.scss$/,
                use: [
                    'vue-style-loader',
                    'css-loader',
                    'sass-loader'
                ]
            }
        ]
    },
    resolve: {
        extensions: [
            '.js',
            '.vue'
        ]
    },
    plugins: [
        new VueLoaderPlugin()
    ]
};

module.exports = {
    optimization: {
        minimize: true,
        minimizer: [new TerserPlugin()],
    },
};

module.exports = config;