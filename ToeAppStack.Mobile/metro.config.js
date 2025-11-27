// metro.config.js

const { getDefaultConfig } = require("expo/metro-config");

module.exports = (() => {
  const config = getDefaultConfig(__dirname);

  // Enable Webpack-style require.context support
  config.transformer.unstable_allowRequireContext = true;

  return config;
})();