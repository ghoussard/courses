/**
 * MongoDB JSON Document Recursive Flat
 * @param {Object|Array} document MongoDB JSON Document
 * @param {string|undefined} prefixKey used by recursivity to prefix deeper keys with parent keys
 */
const flat = (document, prefixKey = undefined) => {
    const keys = Object.keys(document)

    keys.forEach(key => {
        const newKey = prefixKey ? `${prefixKey}_${key}` : key

        if(document[key] instanceof Array || (document[key] instanceof Object && document[key].constructor === Object)) {
            document = {
                ...document,
                ...flat(document[key], newKey)
            }
            delete document[key]
        } else if(prefixKey) {
            document[newKey] = document[key]
            delete document[key]
        }
    });

    return document
}

module.exports = flat