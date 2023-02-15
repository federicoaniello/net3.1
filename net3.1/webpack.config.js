const webpack = require('webpack');
const path = require('path');
const { VueLoaderPlugin } = require('vue-loader');
const TerserPlugin = require("terser-webpack-plugin");
const config = {
    watch: true,
    mode:"production",
    entry: ["/Components/Products/index.js"],
    output: {
        path: path.resolve(__dirname, 'wwwroot/assets/bundles/js'),
        filename: 'products-app.js'
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
        new VueLoaderPlugin({
                compilerOptions: {
                    // treat all tags with a dash as custom elements
                    isCustomElement: (tag) => tag.includes('-')
                }
            }),

    ],
    optimization: {
        minimize: true,
        minimizer: [new TerserPlugin()],
    }
};

module.exports = config;